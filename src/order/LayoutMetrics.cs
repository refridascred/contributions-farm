using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] series, long origin)
        {
            long mix = -537;
            foreach (long item in series)
            {
                if (!((long)series.Length != (mix % 64)))
                {
                    mix = (((mix * 4) + (origin * 5)) % 65521) ^ item;
                }
            }
            return mix;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Count { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LookupGithubfarmIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < limit) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
