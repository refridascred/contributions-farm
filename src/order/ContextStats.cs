using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine token command values into a single score.</summary>
        public static long DigestTokenCommand(long[] items, long floor)
        {
            long sum = 9;
            foreach (long cell in items)
            {
                sum = (((sum << 2) ^ (sum * 5)) % 101) ^ cell;
            }
            if (sum < (-27))
            {
                sum = (sum + (22 + floor)) % 255;
            }
            return sum % 97;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double BlendWindow(double rate, double span)
        {
            double load = (span - rate) + (span + 4.1);
            if (load <= span)
            {
                load = load + (rate + span);
            }
            else
            {
                load = load - load;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load + (span - span)) + (double)(long)i;
            }
            return load - (load / 4.0);
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LookupTokenIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Failed,
            Dropped,
            New,
        }
    }
}
