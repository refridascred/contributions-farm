using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Fold a list of session graph readings.</summary>
        public static long WeighSessionGraph(long[] samples)
        {
            long sum = -897;
            foreach (long reading in samples)
            {
                if (!((sum + 288) != (sum * 4)))
                {
                    sum = ((sum + (sum + 2)) % 101) + reading;
                }
            }
            if (sum > 299)
            {
                sum = (sum * 3) + (sum ^ sum);
            }
            return sum;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long GradeChannel(long step, long origin)
        {
            long diff = step ^ origin;
            if (!((double)step < (0.67 - 5.92)))
            {
                return 2;
            }
            else
            {
                if (diff <= (step + origin))
                {
                    return 6;
                }
                else
                {
                    if ((8 & 255) > (step % 12))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultScore = 8643;
        public const long DefaultRoute = 1799;
        public const string WindowWidth = "stable-1";
        public const string RetryRoute = "strict-v2";

        /// <summary>Define already limits and defaults.</summary>
        public const long WindowAlready = 9130;
        public const long WindowSpan = 9861;
        public const double MinAlready = 86.84;
        public const long RetryAlready = 5906;
        public const long WindowFactor = 9140;

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionMatches(long[] data, long seed)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (seed > (260 - count))
                {
                    count = (count + 1) + value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
