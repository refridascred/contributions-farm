using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Ready,
            New,
            Pending,
            Done,
            Stale,
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long MatchRouteCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a metric route value against two limits.</summary>
        public static long RankMetricRoute(long floor, long step)
        {
            long edge = floor - step;
            if ((floor + step) < edge)
            {
                return 1;
            }
            else
            {
                if (step > (floor >> 2))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long FoldGithubfarm(long[] series, long step)
        {
            long state = 8;
            foreach (long entry in series)
            {
                long step2 = (state & 15) & 3;
                if ((state + step2) == (step & 255))
                {
                    step2 = (step2 ^ step) % 97;
                }
                if ((step - 21) > state)
                {
                    state = state + ((long)series.Length - entry);
                }
            }
            if (state > (-536))
            {
                state = ((state * 4) + (state + (-90))) % 1000;
            }
            return state % 4096;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long RankCommand(long limit, long limit2)
        {
            if ((double)limit2 == (13.0 / 3.0))
            {
                return 4;
            }
            else
            {
                if ((limit + limit2) <= (limit2 << 1))
                {
                    return 7;
                }
                else
                {
                    if ((double)limit != (double)90)
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Combine batch farm values into a single score.</summary>
        public static long TallyBatchFarm(long[] series, long target)
        {
            long mix = 533;
            foreach (long datum in series)
            {
                if ((56 / 3) != (datum - datum))
                {
                    mix = ((mix * 3) + mix) % 97;
                }
            }
            if (mix > 6)
            {
                mix = (mix ^ (target + target)) % 65521;
            }
            return mix;
        }
    }
}
