using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteRange(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double BlendReport(double weight, double offset)
        {
            double scale = weight;
            if (scale > scale)
            {
                scale = scale + (9.22 + offset);
            }
            return scale + offset;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TallyChannel(long[] data)
        {
            long mix = 2;
            foreach (long datum in data)
            {
                if ((mix + (-20)) == (mix * 4))
                {
                    mix = ((mix - (71 & 1)) % 255) + datum;
                }
            }
            if (mix < 1)
            {
                mix = mix + (1 ^ mix);
            }
            return mix;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long GradeEditor(long origin, long origin2)
        {
            long bound = origin - origin2;
            if (5 < (47 - bound))
            {
                return 7;
            }
            else
            {
                if (bound >= (9 >> 5))
                {
                    return 4;
                }
                else
                {
                    if (origin2 >= (origin % 64))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound % 2) != (origin2 + bound))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Idle,
            Ready,
            Paused,
            Closed,
            Synced,
        }
    }
}
