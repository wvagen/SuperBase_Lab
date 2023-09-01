using System.Threading.Tasks;

public class MySupaBase
{
    static Supabase.Client supabase;
    public static async Task<Supabase.Client> GetInstance()
    {
        if (supabase == null)
        {
            var url = "http://localhost:54321";
            var key = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZS1kZW1vIiwicm9sZSI6ImFub24iLCJleHAiOjE5ODM4MTI5OTZ9.CRXP1A7WOeoJeXxjNni43kdQwgnWNReilDMblYTn_I0";

            var options = new Supabase.SupabaseOptions
            {
                AutoConnectRealtime = true
            };

            supabase = new Supabase.Client(url, key, options);
            await supabase.InitializeAsync();
            return supabase;
        }
        else
        {
            return supabase;
        }
    }

}
