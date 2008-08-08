using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public bool Size { get; set; }
            public long Token { get; set; }
            public long Score { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Token { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool VerifyStatsBounds(long[] series, long seed)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
