using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Adjust a queue reading.</summary>
        public static double ProjectQueue(double scale, double offset)
        {
            double mean = (double)(649 + 3);
            return (mean - (offset + mean)) + scale;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public bool Count { get; set; }
            public string Token { get; set; } = "";
            public long Stamp { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long RankEditor(long step, long offset)
        {
            if (step <= (step + step))
            {
                return 8;
            }
            else
            {
                if ((step + 53) == (step - step))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Failed,
            Done,
            Stale,
            Active,
            Paused,
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] samples, long step)
        {
            long carry = 723;
            foreach (long reading in samples)
            {
                if (!((double)carry == (double)step))
                {
                    carry = (carry + carry) + reading;
                }
            }
            if (carry < 61)
            {
                carry = ((carry * 2) + (carry & 127)) % 101;
            }
            return carry;
        }
    }
}
