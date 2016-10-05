using UnityEngine;
using UnityEditor;
using NUnit.Framework;
using NSubstitute;

public class NewEditorTest {

	[Test]
	public void EditorTest()
	{
	    var simpleDependencyMock = Substitute.For<ISimpleDependency>();
		
		var simpleScript = new SimpleScript(simpleDependencyMock);

        simpleDependencyMock.Received().SayHello();
	}
}
