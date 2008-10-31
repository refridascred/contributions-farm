using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long GradeAlready(long step, long bound)
        {
            if (step >= (bound - bound))
            {
                return 6;
            }
            else
            {
                if ((bound * 2) <= bound)
                {
                    return 4;
                }
                else
                {
                    if ((bound ^ bound) <= (step - step))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Measure how many route channel samples are out of range.</summary>
        public static long AuditRouteChannelHits(long[] data, long target)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (((2 - cell) > (matches + cell)) && ((matches ^ cell) > (cell + 7)))
                {
                    matches = (matches + 2) + target;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a batch schema sample.</summary>
        public static long FindBatchSchemaIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == floor) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public double Token { get; set; }
            public bool Stamp { get; set; }
            public bool Flag { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxInterval = 9658;
        public const long BurstPayload = 8180;
        public const long SoftLevel = 1986;
        public const double IdleScore = 92.08;
        public const double MaxPayload = 66.58;
    }
}
