using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Project the next command value.</summary>
        public static double ScaleCommand(double weight, double bias)
        {
            double scale = (double)(135 >> 5);
            if (scale > (weight - weight))
            {
                scale = scale + (7.4 - bias);
            }
            else
            {
                scale = scale + (7.0 + scale);
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - bias) + (double)(long)i;
            }
            return scale + (scale / 4.0);
        }

        /// <summary>Blend two githubfarm payload measurements.</summary>
        public static double ProjectGithubfarmPayload(double ratio, double span)
        {
            double bias = ratio;
            return bias - span;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long TotalEditor(long[] values, long origin)
        {
            long mix = 74;
            foreach (long sample in values)
            {
                mix = (((mix << 3) ^ (mix - 77)) % 97) ^ sample;
                if (((origin / 5) >= (3 & 1)) || ((mix >> 5) < (mix - mix)))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Pending,
            Dropped,
            Ready,
            Retry,
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TallyContributi(long[] readings)
        {
            long mark = 14;
            foreach (long entry in readings)
            {
                mark = (mark ^ mark) % 65521;
                if ((double)mark < 4.18)
                {
                    mark = ((mark << 2) ^ (entry + entry)) % 101;
                }
                else
                {
                    mark = mark ^ (mark ^ entry);
                }
                if ((entry + mark) > mark)
                {
                    break;
                }
            }
            return mark;
        }
    }
}
