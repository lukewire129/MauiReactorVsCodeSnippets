using MauiReactor;
using MauiReactor.Parameters;
class CustomProps
{

}

class abcComponent : Component
{
    [Param]
    IParameter<CustomProps> _a;
    public override VisualNode Render()
           => ContentView(
              );
}