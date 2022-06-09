using System;

using Microsoft.CodeAnalysis.CSharp.Syntax;

using R5T.T0135;

using Instances = R5T.X0011.Instances;


namespace R5T.N0001.Composition.Addition.Simple.Annotated
{
    public static partial class CompilationUnitSyntaxExtensions
    {
        public static AddNodeResult<CompilationUnitSyntax> AddUsingDirective(this CompilationUnitSyntax compilationUnit,
            AnnotatedNode<UsingDirectiveSyntax> usingDirective)
        {
            return compilationUnit.AddNode(
                usingDirective,
                Instances.SyntaxOperator.AddUsingDirective);
        }

        public static AddNodeResult<CompilationUnitSyntax> AddUsingDirective(this CompilationUnitSyntax compilationUnit,
            UsingDirectiveSyntax usingDirective)
        {
            return compilationUnit.AddNode_Untyped(
                usingDirective,
                Instances.SyntaxOperator.AddUsingDirective);
        }
    }
}
