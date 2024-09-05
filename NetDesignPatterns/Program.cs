// See https://aka.ms/new-console-template for more information
using NetDesignPatterns.Creational.Builder.FluentRecursiveGenerics;
using NetDesignPatterns.Creational.Builder.HtmlBuilder;

var builderTester = new HtmlBuilderTester();
builderTester.RunTest();

var genericInheritTester = new PersonBuilderTest();
genericInheritTester.RunTest(true);