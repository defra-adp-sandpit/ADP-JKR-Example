using ADP.JKR.Example.Api.AutoMapper;
using ADP.JKR.Example.Api.Models;
using ADP.JKR.Example.Core.Entities;

using AutoFixture;

using AutoMapper;

namespace ADP.JKR.Example.Api.Tests.AutoMapperTests;

public class AutoMapperProfileTests
{
    [Fact]
    public void AutoMapperProfile_Should_Create_Valid_Mappings()
    {
        // Arrange
        var profile = new AutoMapperProfile();
        var configuration = new MapperConfiguration(cfg => cfg.AddProfile(profile));
        var mapper = new Mapper(configuration);
        var fixture = new Fixture();
        var itemRequest = fixture.Create<ItemRequest>();

        // Act
        var item = mapper.Map<ItemRequest, Item>(itemRequest);

        // Assert
        item.Should().NotBeNull();
        item.Name.Should().Be(itemRequest.Name);
    }
}
