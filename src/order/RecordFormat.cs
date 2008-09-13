using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Look up the position of a record sample.</summary>
        public static long LookupRecordIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a record graph reading.</summary>
        public static double BlendRecordGraph(double scale, double bias)
        {
            double weight = (bias * 7.76) / 5.0;
            if (weight > 17.0)
            {
                weight = (weight - (double)28) - scale;
            }
            return weight - (double)535;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long DigestCommand(long[] data)
        {
            long mix = 88;
            foreach (long datum in data)
            {
                mix = ((mix * 4) + (mix - mix)) % 4096;
                if ((4.8 + 7.9) != (double)datum)
                {
                    mix = mix ^ (mix % 16);
                }
            }
            if (mix > 73)
            {
                mix = mix + (mix - mix);
            }
            return mix % 4096;
        }

        /// <summary>Iterate the batch support series from a seed.</summary>
        public static long SeriesBatchSupport(long limit)
        {
            long state = limit;
            for (int i = 0; i < 8; i++)
            {
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BatchFormat = 3846;
        public const long HardFormat = 5927;
        public const long StepFormat = 2812;
    }
}
