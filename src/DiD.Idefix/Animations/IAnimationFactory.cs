using System.Threading.Tasks;

namespace DiD.Idefix.Animations
{
    internal interface IAnimationFactory
    {
        Task ShowIdefixAsync();
        Task ShowWigglingIdefixAsync();
    }
}
