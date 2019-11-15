import { aspReactTemplatePage } from './app.po';

describe('aspReact App', function() {
  let page: aspReactTemplatePage;

  beforeEach(() => {
    page = new aspReactTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
