using System;
using Machine.Specifications;

namespace Specs
{
    [Subject(typeof(MalleableObject))]
    public class When_reading_an_existing_boolean_property
    {
        Establish context = () => _subject.Property = true;

        Because of = () =>  _result = _subject.Property;

        It should_return_the_correct_value = () => _result.ShouldEqual(true);

        static dynamic _subject = new MalleableObject();
        private static object _result;
    }
}
