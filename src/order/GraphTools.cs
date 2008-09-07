using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Paused,
            Done,
            Pending,
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long CompareCommandCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit record farm readings against a rule.</summary>
        public static long CountRecordFarmOutliers(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((entry << 2) <= (entry ^ 542))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Idle,
            Queued,
            Stale,
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaMatches(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((datum + 54) == (seen >> 3))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
