using AutoFixture.AutoMoq;
using AutoFixture;
using Xunit;
using AutoFixture.Xunit2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastProject.Tests.Attributes
{
    internal class MockAutoDataAttribute : AutoDataAttribute
    {
        /* 1-) AutoDataAttribute : AutoFixture.Xunit2
          2-) Fixture : AutoFixture
          3-) AutoMoqCustomization: AutoFixture.AutoMoq */
        public MockAutoDataAttribute()
            : base(new Fixture().Customize(new AutoMoqCustomization()))
        {
        }
    }
}
