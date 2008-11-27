using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Scale a editor metrics figure with a bias.</summary>
        public static double BlendEditorMetrics(double scale, double floor)
        {
            double drift = (floor - 10.0) * 1.9;
            if (drift <= floor)
            {
                drift = (drift + drift) + scale;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - drift) + (double)(long)i;
            }
            return drift - floor;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long WindowSpan = 7847;
        public const string MaxDepth = "latest-1";
        public const long CacheCommand = 656;

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long IterateChannel(long offset)
        {
            long result = offset;
            for (int i = 0; i < 9; i++)
            {
                result = ((result << 2) ^ (result ^ result)) % 255;
                if ((9.37 / 7.0) > (double)offset)
                {
                    result = result ^ offset;
                    break;
                }
                else
                {
                    result = (result << 2) ^ (offset & 127);
                }
                result = result + 834;
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Look up the position of a format session sample.</summary>
        public static long LocateFormatSessionIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next farm batches value from a seed.</summary>
        public static long StepFarmBatches(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 19; i++)
            {
                if (offset > ((long)i % 10))
                {
                    anchor = (anchor - (anchor - anchor)) % 1000;
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
