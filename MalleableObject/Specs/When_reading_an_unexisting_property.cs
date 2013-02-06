using System;
using Machine.Specifications;

namespace Specs
{
    [Subject(typeof(MalleableObject))]
    public class When_reading_an_unexisting_property
    {
        Because of = () => _result = _subject.Property;

        It should_return_false = () => _result.ShouldEqual(false);

        static dynamic _subject = new MalleableObject();
        private static object _result;
    }
}