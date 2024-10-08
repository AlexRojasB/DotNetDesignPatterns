﻿// See https://aka.ms/new-console-template for more information
using NetDesignPatterns.Creational.Builder.FluentRecursiveGenerics;
using NetDesignPatterns.Creational.Builder.FunctionalBuilder;
using NetDesignPatterns.Creational.Builder.HtmlBuilder;
using NetDesignPatterns.Creational.Factory.FactoryMethod;
using NetDesignPatterns.Creational.Factory.ObjectTrackingBulkReplacement;
using NetDesignPatterns.Creational.Factory.AbstractMethod;
using NetDesignPatterns.Creational.Factory.AbstractMethodOOP;
using NetDesignPatterns.Creational.Prototype.Serialzation;
using NetDesignPatterns.Creational.Singleton.PerThread;

var builderTester = new HtmlBuilderTester();
builderTester.RunTest();

var genericInheritTester = new PersonBuilderTester();
genericInheritTester.RunTest();

var functionalBuilderTester = new FunctionalBuilderTester();
functionalBuilderTester.RunTest();

var factoryMethodTester = new FactoryMethodTester();
factoryMethodTester.RunTest();

var trackingFactoryTester = new TrackingFactoryTester();
trackingFactoryTester.RunTest();

var abstractMethodTester = new AbstractMethodTester();
abstractMethodTester.RunTest();

var abstractMethodOOPTester = new AbstractMethodTesterOOP();
abstractMethodOOPTester.RunTest();

var prototypeSerializationTester = new PrototypeSerializationTester();
prototypeSerializationTester.RunTest();

var perThreadTester = new PerThreadTester();
perThreadTester.RuntTest(true);