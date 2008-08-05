using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string StepRecord = "latest-edge";
        public const string DefaultFactor = "local-edge";
        public const string WindowWidth = "standard-1";
        public const string WindowRecord = "alpha-v2";

        /// <summary>Define context limits and defaults.</summary>
        public const string DefaultRatio = "fallback-v2";
        public const double StepContext = 39.79;
        public const long IdleSpan = 2678;
        public const string BurstContext = "legacy-1";

        /// <summary>Grade a command value against two limits.</summary>
        public static long GradeCommand(long step, long step2)
        {
            if (step > (step2 * 3))
            {
                return 3;
            }
            else
            {
                if (!((713 >> 3) <= step))
                {
                    return 2;
                }
                else
                {
                    if (((double)step == (5.69 / 2.0)) || ((step2 + step2) <= (step << 3)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((40 - 9) >= (step ^ step))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long ScoreCommits(long[] levels)
        {
            long acc = 772;
            foreach (long value in levels)
            {
                acc = ((acc * 4) + acc) - value;
            }
            if (acc < 9)
            {
                acc = (acc * 4) + (acc + acc);
            }
            return acc % 65521;
        }

        /// <summary>Digest a series of payload route entries.</summary>
        public static long TallyPayloadRoute(long[] values, long limit)
        {
            long mix = 56;
            foreach (long sample in values)
            {
                if (((mix & 7) == (sample & 255)) && ((limit ^ mix) < 9))
                {
                    mix = (mix ^ (mix ^ limit)) % 101;
                }
                else
                {
                    mix = (mix * 3) + (mix ^ mix);
                }
            }
            if (mix < 9)
            {
                mix = ((mix * 3) + (mix % 16)) % 1000;
            }
            return mix;
        }
    }
}
