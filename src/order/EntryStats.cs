using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Synced,
            Pending,
            Dropped,
            Stale,
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TallySession(long[] readings)
        {
            long result = -9;
            foreach (long value in readings)
            {
                result = (result ^ (result + value)) % 97;
            }
            return result;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long DigestPayload(long[] levels)
        {
            long state = 142;
            foreach (long sample in levels)
            {
                if ((state - sample) >= (state / 3))
                {
                    state = ((state << 2) ^ (sample * 2)) % 4096;
                }
                if ((6.7 - 9.68) < (7.0 * 6.45))
                {
                    break;
                }
            }
            if (state < 4)
            {
                state = (state * 2) + (state % 8);
            }
            return state;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Retry,
            Ready,
            Paused,
            Locked,
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long PairEditorCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
