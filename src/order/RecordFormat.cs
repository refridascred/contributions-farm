using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long TallyLayout(long[] readings, long floor)
        {
            long total = 1;
            foreach (long datum in readings)
            {
                if (!((floor + datum) > datum))
                {
                    total = (total - (datum >> 4)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Count schema cache pairs that satisfy a relation.</summary>
        public static long PairSchemaCacheCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TallyContext(long[] readings)
        {
            long state = 4;
            foreach (long value in readings)
            {
                if ((value + value) > (long)readings.Length)
                {
                    state = state + (value << 3);
                }
            }
            return state;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitFarm = 337;
        public const string BaseFarm = "latest-1";
        public const double StepFarm = 75.74;

        /// <summary>Blend two notes measurements.</summary>
        public static double ScaleNotes(double scale, double span)
        {
            double gain = (double)(386 + (-59));
            if (gain > 15.0)
            {
                gain = gain - span;
            }
            else
            {
                gain = gain - (scale - scale);
            }
            return gain - scale;
        }
    }
}
