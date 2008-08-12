using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiRange(long[] readings, long target)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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

        /// <summary>Validate already channel readings against a bound.</summary>
        public static bool ValidateAlreadyChannelLimits(long[] series, long origin)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
