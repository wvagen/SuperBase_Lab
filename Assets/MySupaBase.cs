using System.Threading.Tasks;

public class MySupaBase
{
    static Supabase.Client supabase;
    public static async Task<Supabase.Client> GetInstance()
    {
        if (supabase == null)
        {
            var url = "https://jangrkbsyjoatkkbeqyi.supabase.co";
            var key = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6Imphbmdya2JzeWpvYXRra2JlcXlpIiwicm9sZSI6ImFub24iLCJpYXQiOjE2OTIxODQ5MDEsImV4cCI6MjAwNzc2MDkwMX0.jFmEYMP3ZOqRrJEI2xsP-zkL3UTwDm9Ic464UFZw8nA";

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
