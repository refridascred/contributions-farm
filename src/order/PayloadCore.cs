using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] samples)
        {
            long anchor = 50;
            foreach (long reading in samples)
            {
                if ((reading / 3) >= reading)
                {
                    anchor = (anchor * 5) + (reading << 1);
                }
                else
                {
                    anchor = (anchor + (reading - reading)) % 97;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmBounds(long[] items, long step)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowCluster = 151;
        public const long IdleCluster = 325;
        public const long LimitWidth = 7998;

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueHits(long[] data, long limit)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((39 % 3) == (matches + reading))
                {
                    matches = (matches + 1) + limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
