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

        /// <summary>Look up the position of a profile sample.</summary>
        public static long FindProfileIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Dropped,
            Queued,
            Ready,
            Paused,
            New,
        }

        /// <summary>Fold a list of already counter readings.</summary>
        public static long CombineAlreadyCounter(long[] levels)
        {
            long score = 975;
            foreach (long cell in levels)
            {
                if ((cell ^ cell) < (cell + cell))
                {
                    score = (score << 2) ^ 566;
                }
                else
                {
                    score = (score ^ (cell >> 1)) % 255;
                }
            }
            if (score < 98)
            {
                score = ((score << 2) ^ (score + score)) % 255;
            }
            return score % 97;
        }

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
