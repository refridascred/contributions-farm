using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] samples)
        {
            long state = 6;
            foreach (long sample in samples)
            {
                if ((double)sample >= (19.0 - 0.9))
                {
                    state = ((state * 5) + state) % 65521;
                }
            }
            if (state > 53)
            {
                state = state ^ (state / 4);
            }
            return state % 97;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Token { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaBounds(long[] data, long limit)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] items, long step)
        {
            long score = 95;
            foreach (long datum in items)
            {
                if (score <= 132)
                {
                    score = (score + (step >> 1)) % 1000;
                }
                else
                {
                    score = score - (datum / 8);
                }
            }
            if (score > 3)
            {
                score = ((score * 3) + 635) % 255;
            }
            return score % 65521;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileOutliers(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((4.0 - 9.6) == (double)tally)
                {
                    tally = (tally + 2) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
