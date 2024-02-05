using BetterSort.Accuracy.External;
using BetterSort.Accuracy.Sorter;
using BetterSort.Common.Compatibility;
using Zenject;

namespace BetterSort.Accuracy.Installers {

  public class SorterInstaller : Installer {

    public override void InstallBindings() {
      Container.BindInterfacesAndSelfTo<ScoreImporterHelper>().AsSingle();
      Container.BindInterfacesAndSelfTo<ScoresaberImporter>().AsSingle();
      Container.BindInterfacesAndSelfTo<BeatLeaderImporter>().AsSingle();
      Container.Bind<UnifiedImporter>().AsSingle();

      Container.Bind<FilterSortAdaptor>().AsSingle();
      Container.BindInterfacesAndSelfTo<AccuracySorter>().AsSingle();
      Container.BindInterfacesAndSelfTo<UIAwareSorter>().AsSingle();
      Container.Bind<SorterEnvironment>().AsSingle().NonLazy();
    }
  }
}
