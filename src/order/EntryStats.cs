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

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long PairNotesCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderRange(long[] items, long limit)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next route value.</summary>
        public static double ProjectRoute(double weight, double bias)
        {
            double bias2 = (weight - 2.35) + (4.6 / 2.0);
            for (int i = 0; i < 9; i++)
            {
                bias2 = ((bias2 - 5.0) + (double)(long)i) + bias;
            }
            return bias2 - (0.9 + bias2);
        }
    }
}
