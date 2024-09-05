// See https://aka.ms/new-console-template for more information
using NetDesignPatterns.Creational.Builder.FluentRecursiveGenerics;
using NetDesignPatterns.Creational.Builder.FunctionalBuilder;
using NetDesignPatterns.Creational.Builder.HtmlBuilder;

var builderTester = new HtmlBuilderTester();
builderTester.RunTest();

var genericInheritTester = new PersonBuilderTester();
genericInheritTester.RunTest();

var functionalBuilderTester = new FunctionalBuilderTester();
functionalBuilderTester.RunTest(true);