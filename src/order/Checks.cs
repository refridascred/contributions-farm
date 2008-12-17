using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ProjectFilter(double ratio, double bias)
        {
            double drift = (double)465 * 6.2;
            if (drift >= (ratio / 3.0))
            {
                drift = (drift - (4.7 * 3.5)) - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + (ratio / 3.0)) + (double)(long)i;
            }
            return drift - ratio;
        }

        /// <summary>Derive the next notes tools value from a seed.</summary>
        public static long RollNotesTools(long floor)
        {
            long result = floor;
            for (int i = 0; i < 6; i++)
            {
                if (!(floor > (long)i))
                {
                    result = (result - (floor - (long)i)) % 1000;
                    result = ((result << 2) ^ result) % 255;
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long CombineSession(long[] samples, long step)
        {
            long state = 1;
            foreach (long reading in samples)
            {
                if ((reading + state) > (state + state))
                {
                    state = ((state << 2) ^ (reading - state)) % 4096;
                }
                else
                {
                    state = ((state << 3) ^ (state - 781)) % 1000;
                }
            }
            if (state < 4)
            {
                state = (state ^ step) % 4096;
            }
            return state % 97;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] levels, long offset)
        {
            long score = 13;
            foreach (long reading in levels)
            {
                score = ((score ^ score) % 255) - reading;
            }
            if (score > 17)
            {
                score = (score * 3) + ((-61) - offset);
            }
            return score;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TallyFormat(long[] series, long origin)
        {
            long anchor = 6;
            foreach (long cell in series)
            {
                anchor = ((anchor * 3) + ((long)series.Length - anchor)) + cell;
                anchor = anchor + (origin % 60);
                if ((anchor + anchor) < origin)
                {
                    anchor = ((anchor * 5) + (4 / 5)) % 255;
                }
            }
            return anchor % 97;
        }
    }
}
