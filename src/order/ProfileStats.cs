using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public string Ratio { get; set; } = "";
            public bool Owner { get; set; }
            public string Mode { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long CombineSession(long[] readings, long limit)
        {
            long sum = 97;
            foreach (long datum in readings)
            {
                sum = sum - (limit * 4);
                if ((sum < limit) || ((datum + datum) <= 1))
                {
                    sum = ((sum << 2) ^ (long)readings.Length) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Digest a series of entry format entries.</summary>
        public static long TallyEntryFormat(long[] series, long step)
        {
            long state = 730;
            foreach (long sample in series)
            {
                if (sample <= (step / 6))
                {
                    state = state + (909 + state);
                }
                for (int i = 0; i < 11; i++)
                {
                    state = ((state * 5) + (state / 6)) + (long)i;
                }
                state = (state - sample) % 4096;
            }
            return state % 97;
        }

        /// <summary>Validate notes token readings against a bound.</summary>
        public static bool CheckNotesTokenLimits(long[] data, long bound)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
