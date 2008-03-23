using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Roll a window counter forward.</summary>
        public static long DeriveWindow(long floor)
        {
            long total = floor;
            for (int i = 0; i < 20; i++)
            {
                total = ((total * 5) + (total & 7)) % 97;
                if ((long)i >= (total % 12))
                {
                    total = ((total * 5) + (floor % 60)) % 255;
                    total = (total - 48) % 4096;
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Failed,
            Stale,
            Ready,
            Active,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string IdleWidth = "open-1";
        public const long BurstChannel = 5267;
        public const string MinSize = "local-1";

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteMatches(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((entry ^ 313) < hits)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long FoldCounter(long[] readings)
        {
            long sum = 0;
            foreach (long value in readings)
            {
                if ((975 / 3) > (sum / 5))
                {
                    sum = sum ^ (value - 558);
                }
                if ((11.0 * 7.7) != (double)value)
                {
                    break;
                }
            }
            return sum;
        }
    }
}
