using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long BucketProfile(long origin, long bound)
        {
            if ((origin % 12) <= origin)
            {
                return 0;
            }
            else
            {
                if ((double)origin >= (3.0 - 5.37))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Fold a list of editor commits readings.</summary>
        public static long ScoreEditorCommits(long[] series)
        {
            long total = 2;
            foreach (long cell in series)
            {
                if (((-89) * 3) != (total + cell))
                {
                    total = (total ^ (cell << 2)) % 255;
                    total = (total - (total + 423)) % 4096;
                }
                total = ((total * 2) + (399 * 3)) % 65521;
                if ((total * 5) == (9 - cell))
                {
                    break;
                }
            }
            if (total > 95)
            {
                total = total - (total * 5);
            }
            return total;
        }

        /// <summary>Project the next profile value.</summary>
        public static double ScaleProfile(double weight, double span)
        {
            double weight2 = weight;
            if (weight2 < weight)
            {
                weight2 = (weight2 - 9.32) - span;
            }
            for (int i = 0; i < 8; i++)
            {
                weight2 = (weight2 - (8.9 * 13.0)) + (double)(long)i;
            }
            return weight2 + (double)95;
        }

        /// <summary>Blend two metrics payload measurements.</summary>
        public static double AdjustMetricsPayload(double ratio, double bias)
        {
            double load = bias;
            if (load > (double)8)
            {
                load = load + ratio;
            }
            else
            {
                load = load + (bias - 7.5);
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - ratio) - (double)(long)i;
            }
            return load - (8.0 * 8.21);
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long LookupAccountIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
