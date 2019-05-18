namespace Eicon.Graphics
{
    public interface IRenderer
    {
        void Initialize();
        void Deinitialize();
        void ClearBuffer();
        void RenderFrame();
        void SetPixel(int x, int y, byte[] color);
        void PushChanges();
    }
}