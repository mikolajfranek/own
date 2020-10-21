using Own.Backend.NullObjects;

namespace Own.Backend
{
    public static class BackendConfiguration
    {
        //idents of critical sections
        public static Null<object> IDENT_CRITICAL_SECTION_LOGGER_FILE = new Null<object>();
        public static Null<object> IDENT_CRITICAL_SECTION_LOGGER_CONSOLE = new Null<object>();
    }
}
