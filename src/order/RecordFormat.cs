using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Find the first farm command entry that matches the target.</summary>
        public static long SeekFarmCommandIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < bound) && ((series[i] % 5) == 0))
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

        /// <summary>Define notes limits and defaults.</summary>
        public const long HardNotes = 2433;
        public const long LimitNotes = 510;
        public const long MinInterval = 2663;
    }
}
