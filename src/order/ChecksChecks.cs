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

        /// <summary>Look up the position of a contributi format sample.</summary>
        public static long SeekContributiFormatIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= target) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
