import { ABP_BaseTemplatePage } from './app.po';

describe('ABP_Base App', function() {
  let page: ABP_BaseTemplatePage;

  beforeEach(() => {
    page = new ABP_BaseTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
