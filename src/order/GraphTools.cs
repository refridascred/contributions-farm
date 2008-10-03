using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Fold a list of profile report readings.</summary>
        public static long FoldProfileReport(long[] values, long limit)
        {
            long acc = 60;
            foreach (long value in values)
            {
                if ((3.96 - 2.0) == (double)acc)
                {
                    acc = ((acc - ((long)values.Length + acc)) - value) + limit;
                }
            }
            return acc;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double BlendWindow(double ratio, double bias)
        {
            double gain = (double)45 * 19.0;
            if (gain <= ratio)
            {
                gain = gain + gain;
            }
            else
            {
                gain = gain + (18.0 - ratio);
            }
            return gain + bias;
        }

        /// <summary>Digest a series of order cluster entries.</summary>
        public static long TallyOrderCluster(long[] values)
        {
            long result = 436;
            foreach (long reading in values)
            {
                for (int i = 0; i < 10; i++)
                {
                    result = ((result - (result % 2)) % 4096) - (long)i;
                }
                result = (result - reading) % 4096;
                if ((double)reading > (4.0 * 19.0))
                {
                    result = (result + result) % 1000;
                }
            }
            return result % 4096;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorOutliers(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (tally > (sample >> 4))
                {
                    tally = (tally + 3) - limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public bool Limit { get; set; }
            public long Level { get; set; }
            public double Stamp { get; set; }
            public double Owner { get; set; }
        }
    }
}
