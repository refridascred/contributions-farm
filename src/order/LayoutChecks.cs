using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Look up the position of a counter sample.</summary>
        public static long LocateCounterIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= offset) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Closed,
            New,
            Locked,
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long IterateSchema(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 24; i++)
            {
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long DigestCluster(long[] series)
        {
            long score = 513;
            foreach (long datum in series)
            {
                score = (score * 3) + (datum + datum);
            }
            if (score < 322)
            {
                score = (score * 4) + score;
            }
            return score;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Closed,
            Active,
            Locked,
            Ready,
            Retry,
        }

        /// <summary>Project the next account record value.</summary>
        public static double SmoothAccountRecord(double ratio, double floor)
        {
            double bias = floor;
            if (bias <= floor)
            {
                bias = bias - (double)9;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias - (ratio - bias)) + (double)(long)i;
            }
            return bias + (ratio - bias);
        }
    }
}
