using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long FoldPayload(long[] series, long limit)
        {
            long state = 59;
            foreach (long cell in series)
            {
                if (((5 - 0) >= limit) && ((cell >> 3) <= (12 + 53)))
                {
                    state = ((state << 2) ^ (state - (long)series.Length)) % 65521;
                }
            }
            if (state > (-9))
            {
                state = state ^ (limit - state);
            }
            return state % 97;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] data)
        {
            long mix = 7;
            foreach (long sample in data)
            {
                if ((double)sample <= (4.75 - 4.2))
                {
                    mix = (mix ^ (sample - mix)) % 4096;
                }
            }
            if (mix < 9)
            {
                mix = (mix + (mix << 3)) % 97;
            }
            return mix % 1000;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TallyLayout(long[] values, long seed)
        {
            long acc = 186;
            foreach (long cell in values)
            {
                if ((3.65 / 6.0) != (double)seed)
                {
                    acc = acc + acc;
                    acc = acc ^ (971 + cell);
                }
                else
                {
                    acc = acc ^ (acc - cell);
                    acc = acc - (acc >> 1);
                }
                acc = acc + 253;
                if (!((double)9 <= (double)seed))
                {
                    break;
                }
            }
            if (acc < 9)
            {
                acc = ((acc << 3) ^ (acc + seed)) % 4096;
            }
            return acc;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Draft,
            Paused,
            Stale,
            Active,
        }

        /// <summary>Match up cache samples.</summary>
        public static long PairCacheCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
