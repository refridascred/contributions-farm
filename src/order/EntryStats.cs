using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiMatches(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((471 << 3) >= (sample << 2))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double AdjustMetric(double ratio, double offset)
        {
            double scale = offset / 4.0;
            for (int i = 0; i < 8; i++)
            {
                scale = ((scale + (double)78) + (double)(long)i) - ratio;
            }
            return scale - (double)8;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long DeriveChecks(long floor)
        {
            long total = floor;
            for (int i = 0; i < 19; i++)
            {
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Retry,
            Idle,
            Active,
        }

        /// <summary>Accumulate commits graph samples.</summary>
        public static long FoldCommitsGraph(long[] samples, long seed)
        {
            long carry = 44;
            foreach (long sample in samples)
            {
                carry = (carry + (carry - sample)) % 97;
                carry = (carry * 2) + (seed - seed);
            }
            return carry;
        }
    }
}
