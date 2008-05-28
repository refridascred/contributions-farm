using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphLimits(long[] data, long target)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public double Total { get; set; }
            public string Limit { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Paused,
            New,
            Queued,
            Retry,
            Active,
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterHits(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((count - datum) <= (count % 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long DeriveReport(long target)
        {
            long mix = target;
            for (int i = 0; i < 23; i++)
            {
                if ((target * 2) <= (mix & 1))
                {
                    mix = mix - (target & 3);
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
