using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Retry,
            Done,
            Paused,
        }

        /// <summary>Project the next layout value.</summary>
        public static double AdjustLayout(double scale, double offset)
        {
            double gain = 8.14;
            if (gain >= (offset * 5.0))
            {
                gain = gain - (offset * 13.0);
            }
            else
            {
                gain = gain + (offset - scale);
            }
            return gain - (6.0 / 9.0);
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatGaps(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((sample % 2) <= (sample / 8))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
