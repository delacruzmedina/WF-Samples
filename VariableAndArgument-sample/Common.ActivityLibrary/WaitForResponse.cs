using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.ActivityLibrary
{
    public sealed class WaitForResponse<TResult> : NativeActivity<TResult>
    {
        public string ResponseName { get; set; }

        protected override bool CanInduceIdle
        { 
            get
            {
                return true;
            }
        }

        protected override void Execute(NativeActivityContext context)
        {
            context.CreateBookmark(this.ResponseName, new BookmarkCallback(this.ReceivedResponse));
        }

        void ReceivedResponse(NativeActivityContext context, Bookmark bookmark, object obj)
        {
            this.Result.Set(context, (TResult)obj);
        }

    }
}
