using System;

namespace TheCoderForge.Example.MarkDownDocumentation
{
    /// <summary>
    ///     this is a public class
    /// </summary>
    /// <remarks>
    /// This is the remark section.
    /// Here are some examples of how different tags can be used within it and other sections.
    /// We can Link to other documents: <see cref="ExampleEnum">ExampleEnum</see>
    /// We can Link to external URLs: <see href="https://github.com">GitHub</see>
    /// </remarks>
    public class ExamplePublicClass
    {
        
        /// <summary>
        /// summary goes here</summary>
        /// <remarks>
        /// This is the remark section.
        /// Here are some examples of how different tags can be used within it and other sections.
        /// W
        /// </remarks>
        /////////<para>para formatting tag</para>
        ///////// <list>list formatting tag</list>
        ///////// <c>c formatting tag</c>
        ///////// <code>code formatting tag</code>
        ///////// <example>example formatting tag</example>
        ///////// <see></see>
        ///////// <seealso></seealso>
        ///////// <cref></cref>
        ///////// <href></href>
        ///////// <exception></exception>
        public int IntegerProperty { get; set; }

        /// <summary>Summary for method</summary>
        /// <param name="inputObject">summary for parameter</param>
        /// <param name="integerParam">summary for second parameter</param>
        /// <returns>blah</returns>
        /// <value>The value of this element is displayed in IntelliSense in Visual Studio</value>
        public ExamplePublicClass FunctionWithClass(ExamplePublicClass inputObject, int integerParam)
        {
            return null;
        }
      
    }
}
