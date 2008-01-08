using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] data)
        {
            long score = 660;
            foreach (long entry in data)
            {
                if ((score % 16) > (entry * 3))
                {
                    score = score - (entry & 3);
                }
                else
                {
                    score = ((score << 2) ^ (entry % 7)) % 97;
                }
            }
            if (score > 962)
            {
                score = (score - (score ^ score)) % 255;
            }
            return score;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Owner { get; set; }
            public bool Label { get; set; }
            public double Rank { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long StepAlready(long target)
        {
            long carry = target;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    carry = carry ^ ((long)i2 ^ 4);
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Synced,
            Failed,
            Dropped,
            Paused,
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long SortAccount(long step, long limit)
        {
            if ((step * 4) < (step % 3))
            {
                return 7;
            }
            else
            {
                if (step <= (limit / 5))
                {
                    return 2;
                }
                else
                {
                    if ((double)step != (9.2 + 1.33))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
