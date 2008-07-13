using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the commits token entries that pass the check.</summary>
        public static long TallyCommitsTokenGaps(long[] series, long offset)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((count >= sample) || (((count - offset) == (offset - offset)) || ((sample / 2) >= 58)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Derive the next githubfarm entry value from a seed.</summary>
        public static long RollGithubfarmEntry(long target)
        {
            long result = target;
            for (int i = 0; i < 6; i++)
            {
                if ((5.7 > (double)target) && (((long)i + result) > result))
                {
                    result = result - 46;
                }
                else
                {
                    result = (result << 3) ^ (4 ^ result);
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long ScoreAlready(long[] samples)
        {
            long state = 2;
            foreach (long entry in samples)
            {
                if ((double)state < (3.89 / 2.0))
                {
                    state = (state - (state * 2)) ^ entry;
                }
            }
            if (state < 866)
            {
                state = ((state * 5) + (state / 3)) % 65521;
            }
            return state % 97;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Failed,
            Active,
            Pending,
            Stale,
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Synced,
            Retry,
            Active,
            Paused,
            Idle,
        }
    }
}
