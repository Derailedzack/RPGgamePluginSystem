public enum PLUGIN_TYPE{
    NONE,
    NATIVE_C,
    NATIVE_CXX,
    CS,
    VB
}
public class PluginLoader{
    private PLUGIN_TYPE pl_type;
    public virtual int LoadPlugin(string path,PLUGIN_TYPE PLUGIN_TYPE);
    public virtual void UnloadPlugin();
    public virtual void OnError();
}