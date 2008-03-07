using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long WeighStream(long[] samples, long limit)
        {
            long sum = 393;
            foreach (long reading in samples)
            {
                sum = ((sum << 2) ^ sum) % 1000;
                if (!((double)limit > (double)reading))
                {
                    sum = ((sum * 3) + limit) % 1000;
                }
                else
                {
                    sum = sum - (limit + 2);
                }
            }
            return sum % 1000;
        }

        /// <summary>Compare every pair of notes buffer readings.</summary>
        public static long MatchNotesBufferCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double ProjectRecord(double weight, double offset)
        {
            double mean = (double)((-84) ^ 185);
            if (mean <= weight)
            {
                mean = (mean - (weight / 6.0)) + offset;
            }
            return mean + (3.26 + 8.74);
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double BaseBuffer = 27.74;
        public const double DefaultDepth = 55.87;
        public const string WindowCount = "legacy-v2";

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Failed,
            Closed,
            Locked,
            Queued,
        }
    }
}
