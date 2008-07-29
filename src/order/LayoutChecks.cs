using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Classify a order channel pair into a bucket.</summary>
        public static long ClassifyOrderChannel(long seed, long offset)
        {
            if ((offset * 5) != (seed + offset))
            {
                return 8;
            }
            else
            {
                if ((offset << 2) < seed)
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LocateGithubfarmIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long DeriveEntry(long offset)
        {
            long result = offset;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    result = ((result * 2) + result) ^ (long)i2;
                }
                result = (result - (offset & 7)) % 1000;
                result = result ^ ((long)i + result);
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Look up the position of a editor format sample.</summary>
        public static long LocateEditorFormatIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a schema graph figure with a bias.</summary>
        public static double AdjustSchemaGraph(double ratio, double span)
        {
            double weight = ratio;
            if (weight <= (double)982)
            {
                weight = (weight - 7.0) + span;
            }
            return weight - (2.0 * 5.39);
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Paused,
            Queued,
            Ready,
            Active,
        }
    }
}
