using System.Threading.Tasks;

namespace DiD.Idefix.Animations
{
    internal interface IAnimationService
    {
        Task ShowIdefixAsync();
        Task ShowWigglingIdefixAsync();
    }
}
