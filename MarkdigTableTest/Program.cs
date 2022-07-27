using System.Text;
using Markdig;
using Markdig.Renderers.Normalize;

var markdownPipeline = new MarkdownPipelineBuilder()
    .UsePipeTables()
    .Build();

var content = File.ReadAllText("test.md");
var document = Markdown.Parse(content, markdownPipeline);
var builder = new StringBuilder();
var writer = new StringWriter(builder);
var renderer = new NormalizeRenderer(writer);
renderer.Render(document);

Console.Write(builder.ToString());
