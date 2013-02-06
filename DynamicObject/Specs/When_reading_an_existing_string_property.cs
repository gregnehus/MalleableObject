using System;
using Machine.Specifications;

namespace Specs
{
    [Subject(typeof(MalleableObject))]
    public class When_reading_an_existing_string_property
    {
        Establish context = () => _subject.Property = "string";

        Because of = () => _result = _subject.Property;

        It should_return_the_correct_value = () => _result.ShouldEqual("string");

        static dynamic _subject = new MalleableObject();
        private static object _result;
    }
}