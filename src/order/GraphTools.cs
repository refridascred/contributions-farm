using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long CompareProfileCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long OverlapWindowCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double BlendContributi(double rate, double offset)
        {
            double load = (double)((-868) + 76);
            if (load <= (rate * 7.7))
            {
                load = load + (rate + 4.0);
            }
            else
            {
                load = load - offset;
            }
            return load + (rate + load);
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string RetryCommand = "latest-1";
        public const long RetryRatio = 9219;
        public const long RetryCount = 4051;
        public const long SoftCommand = 6370;
        public const string BatchCommand = "stable-1";

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextMatches(long[] items, long seed)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (seed > (count >> 3))
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }
    }
}
