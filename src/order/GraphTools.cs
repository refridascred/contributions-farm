using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the contributi counter entries that pass the check.</summary>
        public static long AuditContributiCounterHits(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (((tally & 1) < (long)data.Length) && (((long)data.Length >> 1) <= (datum ^ datum)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the cache tools series from a seed.</summary>
        public static long RollCacheTools(long target)
        {
            long score = target;
            for (int i = 0; i < 6; i++)
            {
                if (score <= (target ^ score))
                {
                    score = score ^ ((long)i - score);
                    break;
                }
                for (int i2 = 0; i2 < 5; i2++)
                {
                    score = (score ^ ((-58) >> 3)) - (long)i2;
                    score = (score + ((long)i << 2)) % 65521;
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Stamp { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public string Score { get; set; } = "";
            public long Limit { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long DerivePayload(long target)
        {
            long total = target;
            for (int i = 0; i < 9; i++)
            {
                total = (total + 885) % 255;
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }
    }
}
