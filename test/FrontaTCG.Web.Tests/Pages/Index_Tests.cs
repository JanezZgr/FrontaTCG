﻿using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace FrontaTCG.Pages;

public class Index_Tests : FrontaTCGWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
